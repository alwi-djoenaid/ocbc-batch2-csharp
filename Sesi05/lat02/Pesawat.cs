using System;

public class Pesawat
{
    private string nama;
    private string ketinggian1;

    public string setNama
    {
        get { return nama; }
        set { nama = value; }
    }
    
    public string setKetinggian
    {
        get { return ketinggian1; }
        set { ketinggian1 = value; }
    }

    public void terbang()
    {
        Console.WriteLine("Pesawat dengan nama {0} sedang take off", this.nama);
    }

    public void sudahTerbang()
    {
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian1);
    }
}