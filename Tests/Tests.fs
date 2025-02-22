namespace CS220

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.A``() =
    let r: int = Program.prob1 1 2 2
    Assert.AreEqual<int> (8, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.B``() =
    let r: int = Program.prob1 10 1 20
    Assert.AreEqual<int> (500, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.C``() =
    let r: int = Program.prob1 -1 -1 -1
    Assert.AreEqual<int> (2, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.D``() =
    let r: int = Program.prob1 0x12345 1 2
    Assert.AreEqual<int> (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.E``() =
    let r: int = Program.prob1 -0x12345 -0x123456 0x42
    Assert.AreEqual<int> (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.F``() =
    let r: int = Program.prob1 0xa000 0xd000 0x8000
    Assert.AreEqual<int> (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.A``() =
    let r: string = Program.prob2 "AAA"
    Assert.AreEqual<string> ("AAA\n", r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.B``() =
    let r: string = Program.prob2 ""
    Assert.AreEqual<string> ("\n", r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.A``() =
    let r: float = Program.prob3 1.0 0.0 0.0
    Assert.AreEqual<float> (0.0, r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.B``() =
    let r: float = Program.prob3 1.1 1.1 1.1
    Assert.AreEqual<float> (nan, r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.C``() =
    let r: float = Program.prob3 1.0 2.0 1.0
    Assert.AreEqual (-1.0, r, 0.0000001)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.D``() =
    let r: float = Program.prob3 0.0 0.0 2.0
    Assert.AreEqual<float> (nan, r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.E``() =
    let r: float = Program.prob3 nan nan nan
    Assert.AreEqual<float> (nan, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.A``() =
    let r: int = Program.prob4 10
    Assert.AreEqual<int> (31, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.B``() =
    let r: int = Program.prob4 2
    Assert.AreEqual<int> (28, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.C``() =
    let r: int = Program.prob4 9
    Assert.AreEqual<int> (30, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.D``() =
    let r: int = Program.prob4 -1
    Assert.AreEqual<int> (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.E``() =
    let r: int = Program.prob4 0
    Assert.AreEqual<int> (-1, r)
