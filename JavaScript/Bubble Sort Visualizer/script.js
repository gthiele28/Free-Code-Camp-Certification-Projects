function generateElement () {
    return Math.floor(Math.random() * 100) + 1;
  }
  
  function generateArray () {
    return [generateElement(), generateElement(), generateElement(), generateElement(), generateElement()];
  }
  
  function generateContainer () {
    return document.createElement("div");
  }
  
  function fillArrContainer (element, items) {
    element.innerHTML = "";
    for (let i = 0; i < items.length; i++) {
      const newSpan = document.createElement('span');
      newSpan.textContent = items[i];
      element.appendChild(newSpan);
    }
  }
  
  function isOrdered (n1, n2) {
    return n1 <= n2;
  }
  
  function swapElements (items, index) {
    if (!isOrdered(items[index], items[index + 1])) {
      const x = items[index + 1];
      items[index + 1] = items[index];
      items[index] = x;
      return true;
    }
    return false;
  }
  
  function highlightCurrentEls (element, index) {
    const allEls = Array.from(element.getElementsByTagName('*'));
    if (allEls[index]) {
      allEls[index].style.border = "2px dashed red";
    }
    if (allEls[index + 1]) {
      allEls[index + 1].style.border = "2px dashed red";
    }
  }
  
  const generateBtn = document.getElementById("generate-btn");
  let startingArray = document.getElementById("starting-array");
  const sortBtn = document.getElementById("sort-btn");
  const arrayContainer = document.getElementById("array-container");
  let randArr = [];
  
  generateBtn.addEventListener("click", () => {
  
    Array.from(arrayContainer.children).forEach(child => {
      if (child !== startingArray) {
        child.remove();
      }
    });
  
    randArr = generateArray();
    fillArrContainer(startingArray, randArr);
  });
  
  sortBtn.addEventListener("click", () => {
    if (!randArr.length) return;
  
    Array.from(arrayContainer.children).forEach(child => {
      if (child !== startingArray) {
        child.remove();
      }
    });
  
    let arr = [...randArr];
    highlightCurrentEls(startingArray, 0);
    swapElements(arr, 0)
  
    let swapped;
  
    for (let i = 0; i < arr.length - 1; i++) {
  
       swapped = false;
  
      for (let j = 0; j < arr.length - 1; j++) {
        
        if (i === 0 && j === 0) {
          j++;
        }
  
        const stepDiv = generateContainer();
        fillArrContainer(stepDiv, arr);
        highlightCurrentEls(stepDiv, j);
        arrayContainer.appendChild(stepDiv);
  
        if (swapElements(arr, j)) {
          swapped = true;
        }
    }
    if (!swapped) break;
  }
  
    const finalDiv = generateContainer();
    fillArrContainer(finalDiv, arr);
    arrayContainer.appendChild(finalDiv);
  });
  