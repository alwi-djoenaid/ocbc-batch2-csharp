using System;

class Overloading{
    private string name;
    private double phoneNumber;

    public void print(string name){
        this.name = name;
        Console.WriteLine($"Nama : {this.name}");
    }

    public void print(double phoneNumber){
        this.phoneNumber = phoneNumber;
        Console.WriteLine($"Nomor telepon : {this.phoneNumber}");
    }
}