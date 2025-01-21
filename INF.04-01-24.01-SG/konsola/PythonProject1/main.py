pesel = [5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3]
wagi_cyfr = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3]

elementy = input("podaj pesel, oddzielając liczby spacją: ").split()
wprowadzony_pesel = list(map(int, elementy[:11]))

'''**********************************************
nazwa funkcji: Sprawdz_plec
opis funkcji: Funkcja pobiera 10 pozycje PESELu. Sprawdza czy jest ona parzysta czy nieparzysta, w pierwszym przypadku zwraca wartosc 'k', a w drugim 'm'
parametry: p - numer pesel
zwracany typ i opis: Funkcja zwraca string w zaleznosci od parzystosci cyfry. 'k' oznacza kobiete, natomiast 'm' mezczyzne.
autor: <numer zdającego>
***********************************************'''
def sprawdz_plec (p):
    if(p[9]%2==0):
        return 'k'
    else:
        return'm'

'''**********************************************
nazwa funkcji: sprawdz_sume_kontrolna
opis funkcji: Funkcja oblicza sume kontrolna peselu, mnozy odpowiadajace sobie miejsca dwoch tablic - peselu i wagi cyfr w nim zawartych oraz je sumuje. Nastepnie sprawdza poprawnosc numeru PESEL, sprawdzajac czy modulo tej sumy jest równy zeru(niepoprawny pesel), czy rozny od zera(poprawny pesel)
parametry: p - numer pesel
s - suma kontrolna
m - modulo sumy kontrolnej
zwracany typ i opis: Funkcja zwraca string 'true' lub 'false' w zaleznosci od modulo z sumy kontrolnej.
autor: <numer zdającego>
***********************************************'''
def sprawdz_sume_kontrolna(p):
    s = 0
    for i in range(10):
        s = s + (p[i] * wagi_cyfr[i])
    m = s%10
    if(m == 0):
        r=0
    else:
        r = 10-m

    if(r == p[10]):
        return 'true'
    else:
        return 'false'

'''**********************************************
nazwa funkcji: sprawdz
opis funkcji: funkcja przemienia informacje zwracane przez ostatnie funkcje na pelne slowa(kobieta i mezczyzna zamiast k i m, prawidlowa i nieprawidlowa zamiast true i false), oraz wyswietla numer PESEL, plec oraz jego poprawnosc.
parametry: p - numer pesel
plec - wartosc zwracana przez funkcje sprawdz_plec
suma_k - wartosc zwracana przez funkcje sprawdz_sume_kontrolna
autor: <numer zdającego>
***********************************************'''
def sprawdz(p):
    plec = sprawdz_plec(p)
    suma_k = sprawdz_sume_kontrolna(p)

    print("pesel: ", p , "," , 'kobieta' if plec == 'k' else 'mezczyzna', ", suma kontrolna jest " ,  'prawidlowa' if suma_k == 'true' else 'nieprawidlowa')

sprawdz(pesel)
sprawdz(wprowadzony_pesel)