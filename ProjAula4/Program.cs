using ProjAula4;

Carro carro = new Carro();

carro.Id = 1;
carro.Marca = "Fiat";
carro.Modelo = "Toro";
carro.AnoFabricacao = 2022;
carro.AnoModelo = 2022;
carro.Cor = "Preto";
carro.Acelerar(100);
carro.LigarBuzina();
carro.Ligar();
carro.LigarAr();

Carro carro2 = new Carro()
{
    Id = 2,
    Marca = "Hyundai",
    Modelo = "Creta",
    AnoFabricacao = 2020,
    AnoModelo = 2021,
    Cor = "Branco"
};

Console.WriteLine(carro);
Console.WriteLine(carro2);
