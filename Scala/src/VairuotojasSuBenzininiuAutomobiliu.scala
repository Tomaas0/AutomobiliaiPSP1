class VairuotojasSuBenzininiuAutomobiliu (override var Sanaudos : Double, override var BakoTalpa : Int) extends Vairuotojas () with Benzininis{
  override var BakoLikutis: Double = BakoTalpa
}
