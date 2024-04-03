function aggiungi(){
    let varNome = document.getElementById("input-nome").value
    let varCognome =document.getElementById("input-cognome").value
    let varMatricola = document.getElementById("input-matricola").value

    let stud = {
        nome: varNome,
        cognome: varCognome,
        matricola: varMatricola
    }
    elenco.push(stud);
    stampa();
}
function stampa(){
    
    console.log(elenco);
}