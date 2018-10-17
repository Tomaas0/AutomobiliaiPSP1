trait Elektrinis {
  var Rida : Int = 0;
  var MaxKmLikutis : Int;
  var KmLikutis : Int;


  def Vaziuoti(km : Int, daugiklis : Double = 1)
  {
    var kiekReikiaDegalu : Int = (km * daugiklis).toInt;
    if (kiekReikiaDegalu < KmLikutis)
    {
      KmLikutis -= kiekReikiaDegalu;
      Rida += km;
    }
  }

  def LikutisProc(): Double =
  {
    var proc : Double = KmLikutis.toDouble / MaxKmLikutis.toDouble * 100;
    return proc;
  }
  def LikutisKm(): Int =
  {
    return KmLikutis;
  }
}
