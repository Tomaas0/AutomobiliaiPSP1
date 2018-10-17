class AstrusLenktynininkasSuElektriniuAutomobiliu(override var MaxKmLikutis : Int) extends Lenktynininkas () with Elektrinis with AstrusVaziavimas {
  override var KmLikutis: Int = MaxKmLikutis
}