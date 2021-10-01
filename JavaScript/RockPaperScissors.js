const getUserChoice = userInput => {
  userInput = userInput.toLowerCase();

  if (userInput === "scissors" || userInput === "rock" || userInput === "paper") {
    return userInput;
  } else {
    console.log("Error - Incorrect Input!");
  }
}

const getComputerChoice = () => {
  let choice = Math.floor(Math.random() * 3);

  switch (choice) {
    case 0:
      return "scissors";
      break;
    case 1:
      return "rock";
      break;
    case 2:
      return "paper";
      break;
  }
}

function determineWinner(userChoice, computerChoice) {
  if (userChoice === computerChoice) {
    return "It was a Tie!";
  }

  if (userChoice === "rock") {
    if (computerChoice === "paper") {
      return "Computer Wins!";
    } else {
      return "User Wins!";
    }
  }

  if (userChoice === "paper") {
    if (computerChoice === "scissors") {
      return "Computer Wins!";
    } else {
      return "User Wins!";
    }
  }

  if (userChoice === "scissors") {
    if (computerChoice === "rock") {
      return "Computer Wins!";
    } else {
      return "User Wins!";
    }
  }
}

function playGame() {
  const userChoice = getUserChoice("rock");
  const computerChoice = getComputerChoice();

  console.log(`User Choice : ${userChoice}`);
  console.log(`Computer Choice : ${computerChoice}`);

  console.log(determineWinner(userChoice, computerChoice));
}

playGame();
