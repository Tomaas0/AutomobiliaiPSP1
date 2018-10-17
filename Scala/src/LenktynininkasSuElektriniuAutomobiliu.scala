class LenktynininkasSuElektriniuAutomobiliu (override var MaxKmLikutis : Int) extends Lenktynininkas () with Elektrinis with PaprastasVaziavimas {
  override var KmLikutis: Int = MaxKmLikutis
}
