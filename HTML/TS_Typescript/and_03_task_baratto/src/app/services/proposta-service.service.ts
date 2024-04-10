import { Injectable } from '@angular/core';
import { Proposta } from '../models/proposta';
import { v4 as uuidv4 } from 'uuid';
import { Transazione } from '../models/transazione';

@Injectable({
  providedIn: 'root'
})
export class PropostaServiceService {

  constructor() { }

  registraTransazioe(proposta: Proposta){
    const codiceUnico: string = uuidv4();
    let transazione: Transazione = new Transazione(codiceUnico); 
   }
}


