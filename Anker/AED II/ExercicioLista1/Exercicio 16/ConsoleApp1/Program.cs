/* 16 Leia	do usuário o tempo em segundos e escreva em	horas, minutos e segundos.	 
Utilize	cinco métodos, para a leitura e	escrita de dados e para obtenção de horas, minutos e	
segundos a partir do tempo em segundos. */
using System;
class TempoUsuario
{
    int _Segundos;
    public TempoUsuario(int segundos)
    {
        _Segundos = segundos;
    }
    public int Get_Segundos()
    {
        return _Segundos;
    }
    protected void Set_segundos(int segundos)
    {
        _Segundos = segundos;
    }
    public int Ler_Segundos()
    {
        Console.WriteLine("Escreva em Segundos um tempo e iremos transformar em horas, minutos e segundos:");
        int segundos;
        string a = Console.ReadLine();
        int.TryParse(a, out segundos);
        return segundos;
    }

    public int Horas(int segundos)
    {
        return segundos / 3600;
    }
    public int Minutos(int segundos)
    {
        int minutos = (segundos % 3600) / 60;
        return minutos;
    }
    public int Segundos(int segundos)
    {
        int seg = (segundos % 3600) % 60;
        return seg;
    }
    public void Tempo_Completo(int hora, int minutos, int segundos)
    {
        Console.Write($"{hora} Hora(s) ");
        Console.Write($"{minutos} minuto(s) e");
        Console.WriteLine($" {segundos} Segundo(s)");
    }
    static void Main()
    {
        int horas, minutos, segundo;
        TempoUsuario usuario = new TempoUsuario(0);
        int segundos = usuario.Ler_Segundos();

        horas = usuario.Horas(segundos);
        minutos = usuario.Minutos(segundos);
        segundo = usuario.Segundos(segundos);
        usuario.Tempo_Completo(horas, minutos, segundo);

    }



}