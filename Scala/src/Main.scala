object Main extends App{
  var Tomas = new VairuotojasSuBenzininiuAutomobiliu(10, 90)
  var Veganas = new VairuotojasSuElektriniuAutomobiliu(400)

  var Pirmas = new LenktynininkasSuBenzininiuAutomobiliu(10, 90)
  var Antras = new AstrusLenktynininkasSuBenzininiuAutomobiliu(10, 90)
  var Trecias = new LenktynininkasSuElektriniuAutomobiliu(400)
  var Ketvirtas = new AstrusLenktynininkasSuElektriniuAutomobiliu(400)

  var Test = new Lenktynininkas() with Elektrinis with AstrusVaziavimas {
    override var MaxKmLikutis: Int = 100
    override var KmLikutis: Int = 100
  }
  Test.Lenktyniauti(10)

  Tomas.Vairuoti(100)
  Veganas.Vairuoti(100)

  Pirmas.Lenktyniauti(50)
  Antras.Lenktyniauti(50)
  Trecias.Lenktyniauti(50)
  Ketvirtas.Lenktyniauti(50)
}
