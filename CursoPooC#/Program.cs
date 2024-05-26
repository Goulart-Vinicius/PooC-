using CursoPooC_;

Musica musica1 = new Musica();
musica1.nome = "Nihil";
musica1.artista = "Ghostmane";
musica1.duracao = 218;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "Duality";
musica2.artista = "Slipknot";
musica2.duracao = 314;
musica2 .disponivel = false;

musica1.showMusic();
musica2.showMusic();


//exericio 1

ContaBancaria conta = new ContaBancaria();
conta.titular = "Vinícius";
conta.saldo = 324;
conta.senha = "123";
conta.numeroIndicador = 1;

Console.WriteLine($"Titular : {conta.titular}");
Console.WriteLine($"Saldo : R${conta.saldo}");

conta.showinformations();