trait Benzininis {

  var Rida : Int = 0
  var BakoTalpa : Int
  var BakoLikutis : Double
  var Sanaudos : Double

   def Vaziuoti(km : Int, daugiklis : Double = 1)
  {
    var kiekReikiaDegalu : Double= Sanaudos * daugiklis / 100 * km.toDouble;
    if(kiekReikiaDegalu < BakoLikutis)
    {
      BakoLikutis -= kiekReikiaDegalu;
      Rida += km;
    }
  }
  def LikutisProc(): Double =
  {
    return BakoLikutis.toDouble / BakoTalpa.toDouble * 100;
  }
  def LikutisKm() : Int =
  {
    var likutis : Int = (BakoLikutis / Sanaudos * 100).toInt;
    return likutis;
  }
}
