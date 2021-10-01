let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:
function generateTarget() {
  return Math.floor(Math.random() * 9 + 1);
}

function compareGuesses(userGuess, computerGuess, target) {
 
  const userDifference = Math.abs(userGuess - target); 
  const computerDifference = Math.abs(computerGuess - target); 

  if (userDifference < computerDifference) {
    return true;
  } else if (userDifference > computerDifference) {
    return false;
  }
}

function updateScore(winner) {
  if (winner === "human") {
    humanScore ++;
  } else if (winner === "computer") {
    computerScore ++;
  }
}

function advanceRound() {
  currentRoundNumber ++;
}