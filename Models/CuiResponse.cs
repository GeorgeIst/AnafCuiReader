using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest01._03.Models
{
    public class CuiResponse
    {
        public int cui { get; set; }
        public string data { get; set; }
        public string denumire { get; set; }
        public string adresa { get; set; }
        public bool scpTVA { get; set; }
        public string data_inceput_ScpTVA { get; set; }
        public string data_sfarsit_ScpTVA { get; set; }
        public string data_anul_imp_ScpTVA { get; set; }
        public string mesaj_ScpTVA { get; set; }
        public string dataInceputTvaInc { get; set; }
        public string dataSfarsitTvaInc { get; set; }
        public string dataActualizareTvaInc { get; set; }
        public string dataPublicareTvaInc { get; set; }
        public string tipActTvaInc { get; set; }
        public bool statusTvaIncasare { get; set; }
        public string dataInactivare { get; set; }
        public string dataReactivare { get; set; }
        public string dataPublicare { get; set; }
        public string dataRadiere { get; set; }
        public bool statusInactivi { get; set; }
        public string dataInceputSplitTVA { get; set; }
        public string dataAnulareSplitTVA { get; set; }
        public bool statusSplitTVA { get; set; }
        public string iban { get; set; }

        public CuiResponse()
        {
        }

        public CuiResponse(int cui, string data, string denumire, string adresa, bool scpTVA, string data_inceput_ScpTVA, string data_sfarsit_ScpTVA, string data_anul_imp_ScpTVA, string mesaj_ScpTVA, string dataInceputTvaInc, string dataSfarsitTvaInc, string dataActualizareTvaInc, string dataPublicareTvaInc, string tipActTvaInc, bool statusTvaIncasare, string dataInactivare, string dataReactivare, string dataPublicare, string dataRadiere, bool statusInactivi, string dataInceputSplitTVA, string dataAnulareSplitTVA, bool statusSplitTVA, string iban)
        {
            this.cui = cui;
            this.data = data;
            this.denumire = denumire;
            this.adresa = adresa;
            this.scpTVA = scpTVA;
            this.data_inceput_ScpTVA = data_inceput_ScpTVA;
            this.data_sfarsit_ScpTVA = data_sfarsit_ScpTVA;
            this.data_anul_imp_ScpTVA = data_anul_imp_ScpTVA;
            this.mesaj_ScpTVA = mesaj_ScpTVA;
            this.dataInceputTvaInc = dataInceputTvaInc;
            this.dataSfarsitTvaInc = dataSfarsitTvaInc;
            this.dataActualizareTvaInc = dataActualizareTvaInc;
            this.dataPublicareTvaInc = dataPublicareTvaInc;
            this.tipActTvaInc = tipActTvaInc;
            this.statusTvaIncasare = statusTvaIncasare;
            this.dataInactivare = dataInactivare;
            this.dataReactivare = dataReactivare;
            this.dataPublicare = dataPublicare;
            this.dataRadiere = dataRadiere;
            this.statusInactivi = statusInactivi;
            this.dataInceputSplitTVA = dataInceputSplitTVA;
            this.dataAnulareSplitTVA = dataAnulareSplitTVA;
            this.statusSplitTVA = statusSplitTVA;
            this.iban = iban;
        }
        public override string ToString()
        {
            return "CuiResponse{" +
                    "cui=" + cui +
                    ", data='" + data + '\'' +
                    ", denumire='" + denumire + '\'' +
                    ", adresa='" + adresa + '\'' +
                    ", scpTVA=" + scpTVA +
                    ", data_inceput_ScpTVA='" + data_inceput_ScpTVA + '\'' +
                    ", data_sfarsit_ScpTVA='" + data_sfarsit_ScpTVA + '\'' +
                    ", data_anul_imp_ScpTVA='" + data_anul_imp_ScpTVA + '\'' +
                    ", mesaj_ScpTVA='" + mesaj_ScpTVA + '\'' +
                    ", dataInceputTvaInc='" + dataInceputTvaInc + '\'' +
                    ", dataSfarsitTvaInc='" + dataSfarsitTvaInc + '\'' +
                    ", dataActualizareTvaInc='" + dataActualizareTvaInc + '\'' +
                    ", dataPublicareTvaInc='" + dataPublicareTvaInc + '\'' +
                    ", tipActTvaInc='" + tipActTvaInc + '\'' +
                    ", statusTvaIncasare=" + statusTvaIncasare +
                    ", dataInactivare='" + dataInactivare + '\'' +
                    ", dataReactivare='" + dataReactivare + '\'' +
                    ", dataPublicare='" + dataPublicare + '\'' +
                    ", dataRadiere='" + dataRadiere + '\'' +
                    ", statusInactivi=" + statusInactivi +
                    ", dataInceputSplitTVA='" + dataInceputSplitTVA + '\'' +
                    ", dataAnulareSplitTVA='" + dataAnulareSplitTVA + '\'' +
                    ", statusSplitTVA=" + statusSplitTVA +
                    ", iban='" + iban + '\'' +
                    '}';
        }
    }
}
