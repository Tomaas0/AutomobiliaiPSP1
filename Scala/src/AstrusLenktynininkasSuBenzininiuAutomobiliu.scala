class AstrusLenktynininkasSuBenzininiuAutomobiliu (override var Sanaudos : Double, override var BakoTalpa : Int) extends Lenktynininkas with Benzininis with AstrusVaziavimas {
  override var BakoLikutis: Double = BakoTalpa
}
