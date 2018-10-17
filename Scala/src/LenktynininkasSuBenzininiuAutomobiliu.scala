class LenktynininkasSuBenzininiuAutomobiliu (override var Sanaudos : Double, override var BakoTalpa : Int) extends Lenktynininkas with Benzininis with PaprastasVaziavimas {
  override var BakoLikutis: Double = BakoTalpa
}
