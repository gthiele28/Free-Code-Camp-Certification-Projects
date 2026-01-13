const poll = new Map();

function addOption (option) {
  if (option === "") {
    return "Option cannot be empty.";
  } else if (poll.has(option)) {
    return `Option "${option}" already exists.`;
  } else {
    poll.set(option, new Set());
    return `Option "${option}" added to the poll.`;
  }
}

function vote (option, voterId) {
  if (!poll.has(option)) {
    return `Option "${option}" does not exist.`;
  } else if (poll.get(option).has(voterId)) {
    return `Voter ${voterId} has already voted for "${option}".`;
  } else {
    poll.get(option).add(voterId);
    return `Voter ${voterId} voted for "${option}".`;
  }
}

function displayResults () {
  let myStr = "Poll Results:";
  poll.forEach((value, key) => {
    myStr += `\n${key}: ${value.size} votes`;
  });
  return myStr;
}

console.log(addOption("Turkey"));
console.log(addOption("Morocco"));
console.log(addOption("Spain"));

console.log(vote("Turkey", "1"));
console.log(vote("Turkey", "2"));
console.log(vote("Morocco", "3"));

console.log(displayResults());