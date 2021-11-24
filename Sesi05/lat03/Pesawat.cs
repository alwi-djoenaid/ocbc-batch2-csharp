using System;

class Pesawat{
    protected string name;
    protected int jumlahRoda;
    protected string ketinggian;
    protected int jumlahPenumpang;

    public string setName{
        get { return name; }
        set { name = value; }
    }

    public int setJumlahRoda{
        get { return jumlahRoda; }
        set { jumlahRoda = value; }
    }

    public string setKetinggian{
        get { return ketinggian; }
        set { ketinggian = value; }
    }

    public int setJumlahPenumpang{
        get { return jumlahPenumpang; }
        set { jumlahPenumpang = value; }
    }

    public void terbang(){
        Console.WriteLine($"Pesawat {this.name} dengan {this.jumlahRoda} sedang terbang membawa {this.jumlahPenumpang} penumpang");
    }

    public void terbangTinggi(){
        Console.WriteLine($"Pesawat {this.name} terbang dengan ketinggian {this.ketinggian}");
    }
}

class PesawatTempur: Pesawat{
    public void terbang(){
        Console.WriteLine($"Pesawat {this.name} dengan {this.jumlahRoda} sedang terbang membawa {this.jumlahPenumpang} penumpang di kapal perang");
    }

    public void terbangTinggi(){
        Console.WriteLine($"Pesawat {this.name} terbang dengan ketinggian {this.ketinggian} dan sedang melakukan patroli");
    }
}