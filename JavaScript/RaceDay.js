let raceNumber = Math.floor(Math.random() * 1000);

let earlyRegister = false;
let runnerAge = 18;

if (runnerAge > 18 && earlyRegister === true)
{
  raceNumber += 1000;
}

if (runnerAge > 18 && earlyRegister === true)
{
  console.log(`Runner ${raceNumber}: You registered early so will race at 9:30am.`);
} 
else if (runnerAge > 18 && earlyRegister === false)
{
  console.log(`Runner ${raceNumber}: You registered late so will race at 11:00am.`);
}
else if (runnerAge < 18)
{
  console.log(`Runner ${raceNumber}: Youth registrants will race at 12:30am.`);
} 
else
{
  console.log(`Runner ${raceNumber}: Please see the registration desk.`);
}
