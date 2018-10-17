abstract class Lenktynininkas {
    def Daugiklis(km: Int): Double
    def Vaziuoti(km: Int, kuroDaugiklis: Double)
    def LikutisProc(): Double
    def LikutisKm(): Int

    def Lenktyniauti(km: Int) {
        Vaziuoti(km, Daugiklis(km))
        Console.println("Pralenktyniavo " + km + "km")
        Console.println("Liko " + LikutisProc() + "% bako")
        Console.println("Dar galima nuvaziuoti " + LikutisKm() + "km")
        Console.println("")
    }
}
