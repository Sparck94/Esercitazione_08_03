import { Oggetto } from "./oggetto";
import { Persona } from "./persona";
import { Transazione } from "./transazione";

export class Proposta {
    private codice: number | undefined;
    private offerente: Persona | undefined;
    private acquirente: Persona | undefined;
    private oggettoOff: Oggetto | undefined;
    private oggettoAcqu: Oggetto | undefined;
    private stato: boolean = false;
    private transazione: Transazione | undefined;

    constructor(cod?: number, off?: Persona, acqu?: Persona, oggOff?: Oggetto, oggAcqu?: Oggetto){
        this.codice = cod;
        this.offerente = off;
        this.acquirente = acqu;
        this.oggettoOff = oggOff;
        this.oggettoAcqu = oggAcqu;
    }
}
