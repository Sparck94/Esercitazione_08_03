import { Oggetto } from "./oggetto";
import { Proposta } from "./proposta";

export class Persona {
    private codice: string | undefined;
    private nominativo: string | undefined;
    private listaOgg: Oggetto[] = new Array();
    private listaProp: Proposta[] = new Array();

    constructor(cod?: string, nominativo?: string){
        this.codice = cod;
        this.nominativo = nominativo;
    }
    // ngOnInit(){
    //     // debugger;
    //     this.listaprod = this.service.recuperaProdotti();
    //   }
}
