let saluta = "Hello world!";            //Tipo di dato stringa

let intero = 1234;                      //Tipi di dato numerici
let float = 123.23;

let booleano = true;                    //Tipo di dato booleano

let prova = null;                       //Tipi di dato speciali
let provaDue;

let persona = {
    nome: "Giovanni",                   //Tipo di dato Oggetto
    cognome: "Pace"
}

//-------------------------------------------------------------------

let oggi = new Date();
console.log(oggi);

let insieme = new Set([1,2,3,4,1,"Lamborghini", {nome: "Giovanni"}]);
console.log(insieme);

//-------------------------------------------------------------------

let equivalentaHashTable = new Map();
equivalentaHashTable.set("Chiave uno", "Giovanni");
equivalentaHashTable.set("Chiave due", 52);
equivalentaHashTable.set("Chiave tre", {nome: "Marika"});

console.log(equivalentaHashTable);
