var sm = new PlayerStateMachine();

var langkah = new (string Ket, bool Moving, bool Jump, bool Grounded, float Vy, int Hp)[]
{
    ("diam",                  false, false, true,  0f,  100),
    ("tombol arah ditekan",   true,  false, true,  0f,  100),
    ("tombol lompat",         true,  true,  false, 5f,  100),
    ("masih naik",            true,  false, false, 2f,  100),
    ("mulai turun",           true,  false, false, -3f, 100),
    ("mendarat",              false, false, true,  0f,  100),
    ("tombol arah ditekan",   true,  false, true,  0f,  100),
    ("tombol arah dilepas",   false, false, true,  0f,  100),
    ("terkena damage (HP 0)", false, false, true,  0f,  0),
};

Console.WriteLine($"Awal                     -> {sm.State}");
foreach (var s in langkah)
{
    sm.Update(s.Moving, s.Jump, s.Grounded, s.Vy, s.Hp);
    Console.WriteLine($"{s.Ket,-24} -> {sm.State}");
}