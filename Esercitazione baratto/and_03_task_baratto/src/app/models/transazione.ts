import { Proposta } from "./proposta";

export class Transazione {
    private codice: string | undefined;
    private proposta: Proposta | undefined;
    private data: Date = new Date();
    

    constructor(cod?: string, proposta?: Proposta){
        this.codice = cod;
        this.proposta = proposta;
    }
}
