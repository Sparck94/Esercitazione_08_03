import { Injectable } from '@angular/core';
import { Oggetto } from '../models/oggetto';
import { Proposta } from '../models/proposta';
import { Persona } from '../models/persona';
import { v4 as uuidv4 } from 'uuid';
import { Transazione } from '../models/transazione';

@Injectable({
  providedIn: 'root'
})
export class PersonaServiceService {
  private elenco: Oggetto[] = new Array();
  private listaProposte: Proposta[] = new Array();
  private idProposta: number = 0;

  constructor() {
    this.elenco.push(new Oggetto("PLL123", "Pallone", "Rotondo",));
    this.elenco.push(new Oggetto("FCL123", "Fucile", "Bello"));
    this.elenco.push(new Oggetto("RTN", "Ruotino", "Molto utile",));
  }

  recuperaOggetto() : Oggetto[] {
    return this.elenco;
  }

  inserisciOggetto(objPro: Oggetto) : boolean {
    if(objPro){
      this.elenco.push(objPro);
      return true;
    }

    return false;
  }
  rimuoviOggetto(codice: string) : boolean {
    for(let i = 0; i < this.elenco.length; i++){
      if(this.elenco[i].getCodice()=== codice){
        this.elenco.splice(i,1);
        return true
      }
    } return false;
    };
  propostaBaratto(cod?: string, off?: Persona, acqu?: Persona, ogg?: Oggetto){
    let id: number = this.idProposta;
    let proposta: Proposta = new Proposta(id, off, acqu, ogg)
    this.idProposta++;
    this.listaProposte.push(proposta)
  }
  gestisciRichiesta(proposta:Proposta, risposta:boolean): boolean{
    if(risposta){
      const codiceUnico: string = uuidv4();
      let transazione: Transazione = new Transazione(codiceUnico, proposta);
      return risposta;
    }
    else{
      return false;
    }  
  }
}
  
  

