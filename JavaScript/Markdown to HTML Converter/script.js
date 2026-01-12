const markdownEl = document.getElementById("markdown-input");
const rawHtmlEl = document.getElementById("html-output");
const previewEl = document.getElementById("preview");

console.log(markdownEl);

function convertMarkdown () {
  let lines = markdownEl.value.split("\n");
  let outputStr = "";
  for (let i = 0; i < lines.length; i++) {
    outputStr += convertLine(lines[i]);
  }
  return outputStr;
}

function convertLine (line) {
  line = line.trimStart();
  let location = line.indexOf(" ");
  let marker = line.slice(0, location);
  let content = line.slice(location + 1);

  //CHECK LINE FOR IMAGE/LINK FIRST BECAUSE IT'S SO DIFFERENT!
  if (line[0] === "!") {
    //image
    return "<img alt='" + line.slice(line.indexOf("[") + 1, line.indexOf("]")) + "' src=" + line.slice(line.indexOf("(") + 1, line.indexOf(")")) + ">";
  } else if (line[0] === "[") {
    //link
    return "<a href='" + line.slice(line.indexOf("(") + 1, line.indexOf(")")) + "'>" + line.slice(line.indexOf("[") + 1, line.indexOf("]")) + "</a>";
  }

  //CHECK FOR STRONG/ITALICS IN CONTENT FIRST THEN RUN SECOND IF!
  content = italicize(content);

  if (marker === "#") {
    return "<h1>" + content + "</h1>\n";
  } else if (marker === "##") {
    return "<h2>" + content + "</h2>";
  } else if (marker === "###") {
    return "<h3>" + content + "</h3>";
  } else if (marker === ">") {
    return "<blockquote>" + content + "</blockquote>";
  }

  return italicize(line);
}

function italicize(str) {
  console.log(str);
  return str
    .replace(/(\*\*|__)(.*?)\1/g, '<strong>$2</strong>')
    .replace(/(\*|_)(.*?)\1/g, '<em>$2</em>');
}

markdownEl.addEventListener("input",
  () => {
    let x = convertMarkdown();
    rawHtmlEl.textContent = x;
    previewEl.innerHTML = x;
  }
);