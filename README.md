Dette er et simpelt C#-konsolprogram, som simulerer et lille reservedelslager.
Programmet lader brugeren spørge efter en bestemt reservedel og fortæller, om delen findes på lager.

**Funktioner**
Et foruddefineret lager med:
hydraulic pump
PLC module
servo motor
Brugeren kan skrive navnet på en reservedel for at tjekke, om den er på lager.
Programmet svarer også på særlige spørgsmål som:
"Do you actually have any parts?"
"Is there anything in stock at all?"
Hvis den ønskede del findes, giver programmet besked og afslutter.
Hvis delen ikke findes, får brugeren en besked og kan fortsætte.

**Sådan fungerer det**
Programmet starter med en velkomst og spørger brugeren, hvilken reservedel der ønskes.
Brugeren skriver et navn eller et specialspørgsmål.
Programmet:
viser hele lageret, hvis brugeren stiller et specialspørgsmål
tjekker om input matcher en del på lager
giver et svar ud fra dette
Programmet afslutter kun, når brugeren beder om en reservedel, som faktisk findes.

**Teknologier brugt**
C#
.NET Console Application
