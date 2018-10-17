abstract class Vairuotojas {
  def Vaziuoti(km: Int, kuroDaugiklis : Double)
  def LikutisProc() : Double
  def LikutisKm() : Int
  def Vairuoti(km : Int)
  {
    Vaziuoti(km, 1)
    Console.println("Pravaziavo " + km + " km")
    Console.println("Liko " + LikutisProc() + "% bako")
    Console.println("Dar galima nuvaziuoti " + LikutisKm() + "km")
    Console.println("")
  }
}
