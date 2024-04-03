function aggiungi(){
    let nome=document.getElementById(input-nome).value;
    let cognome=document.getElementById(input-cognome).value;
    let telefono=document.getElementById(input-numero).value;

    contenuto+=`
        <tr>
            <td>${i+1}</td>
            <td>${nome}</td>
            <td>${cognome}</td>
            <td>${telefono}</td>
        </tr>
        `
    document.getElementById("corpo-tabella").innerHTML = contenuto
}