using System;

public class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    // Constructor
    public Araba(string seriNumarasi, string marka, string model, string renk, int kapiSayisi)
    {
        UretimTarihi = DateTime.Now;
        SeriNumarasi = seriNumarasi;
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi;
    }
}
