class VairuotojasSuElektriniuAutomobiliu (override var MaxKmLikutis: Int) extends Vairuotojas () with Elektrinis{
  override var KmLikutis: Int = MaxKmLikutis
}
