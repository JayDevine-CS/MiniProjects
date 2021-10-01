// Returns a random DNA base
const returnRandBase = () => {
  const dnaBases = ['A', 'T', 'C', 'G']
  return dnaBases[Math.floor(Math.random() * 4)] 
}

// Returns a random single stand of DNA containing 15 bases
const mockUpStrand = () => {
  const newStrand = []
  for (let i = 0; i < 15; i++) {
    newStrand.push(returnRandBase())
  }
  return newStrand
};

// Function Factory to create a large amount of instances of the object
const pAequorFactory = (num, dnaStrand) => {
  return {
    specimenNum: num,
    dna: dnaStrand,
    // Mutate a single base of DNA within a strand
    mutate() {
      const currBase = Math.floor(Math.random() * 15);
      let randBase = returnRandBase();
      if (this.dna[currBase] !== randBase) {
        this.dna[currBase] = randBase;
      } else {
        randBase = returnRandBase();
      }
    return this.dna;
    },
    // Find out how similar two sets of DNA are 
    compareDNA(pAequor) {
      const currDNA = this.dna;
      const compareDNA = pAequor.dna;
      let common = 0;
      for(let i = 0; i < 15; i++) {
        if (currDNA[i] === compareDNA[i]) {
          common++;
        }
      }
      let percentage = Math.floor((common / 16) * 100);
      console.log(`Specimen #${this.specimenNum} and specimen #${pAequor.specimenNum} have ${percentage}% DNA in common.`);
    },
    // Find out whether the organism is likely to survive
    willLikelySurvive() {
      const currDNA = this.dna;
      let higherChance = 0;
      for(let i = 0; i < 15; i++) {
        if (currDNA[i] === 'C' || currDNA[i] === 'G') {
          higherChance++;
        }
      }
      let percentage = Math.floor((higherChance / 16) * 100);
      if (percentage > 60) {
        return true;
      } else {
        return false;
      }
    }
  }
}

// Create 30 Organisms capable of Surviving
const survivingSpecimen = [];
let idCounter = 1;

while (survivingSpecimen.length < 30) {
  let newOrg = pAequorFactory(idCounter, mockUpStrand());
  if (newOrg.willLikelySurvive()) {
    survivingSpecimen.push(newOrg);
  }
  idCounter++;
}

console.log(survivingSpecimen)

