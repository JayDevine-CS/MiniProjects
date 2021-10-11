// Test - Version Control Working
// Plan - Create a Random Message Generator
// Topic - Day Out Itinerary
// Messages - Activity, Restaurant, Company and Movie

// Store Message Values in Arrays
const activities = ['Sports', 'Mini Golf', 'Bike Ride', 'Go to Beach', 'Hiking',  'Escape Room', 'Rock Climbing', 'Bowling', 'Karaoke', 'Museum', 'Art Gallery', 'Trampoline Park'];
const restuarants = ['Five Guys', 'McDonalds', 'Pizza Hut', 'Nandos', 'Yo Sushi', 'Wagamama', 'BarBurrito', 'TacoBell', 'KFC'];
const company = ['Friends', 'Family', 'Yourself(Not Weird)'];
const movies = ['2001: A Space Odyssey', 'The Godfather', 'Citizen Kane', 'Raiders of the Lost Ark', 'Seven Samurai', 'Star Wars', 'The Blind Side'];

// Return Random Index within Arrays Length
function getRandNum(arr) {
    let num = Math.floor(Math.random() * arr.length);
    return num;   
}

// Create and Display Random Messages
console.log("-- Welcome to your Itenerary Generator! --\n");
console.log("Firstly, the activity for the day is...");
console.log(activities[getRandNum(activities)]);

console.log("\nSecondly, after having all your fun you should eat at...");
console.log(restuarants[getRandNum(restuarants)]);

console.log("\nNext, we would like you to spend the day with...");
console.log(company[getRandNum(company)]);

console.log("\nand Finally, you should conclude the day with the movie...");
console.log(movies[getRandNum(movies)]);


