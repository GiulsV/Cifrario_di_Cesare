// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Realizzare un programma in grado di CRIPTARE e DECRIPTARE una stringa inserita nell’utente con la strategia di criptazione nota come “IL CIFRARIO DI CESARE”
//Mi raccomando ci sono diversi modi di integrarlo, scegliete una strategia semplice in base a quello che abbiamo spiegato:
//      l’utente inserisce una stringa da criptare / decriptare
//      l’utente inserisce una chiave numerica per effettuare la criptazione / decriptazione della stringa inserita


//Prova 1 - da rivedere
Console.WriteLine("Cifrario di Cesare");

char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

//Scelta azione
Console.WriteLine("Premi [c] se vuoi CRIPTARE oppure [d] se vuoi DECRIPTARE il messaggio");
string userChoice = Console.ReadLine().ToLower();

if (userChoice == "c")
{
    Encrypt();
}
else if (userChoice == "d")
{
    Decrypt();
}
else
{
    Console.WriteLine("Errore! Riprova");
}

void Encrypt()
{
    Console.WriteLine("Inserisci il tuo messaggio");
    string userMessage = Console.ReadLine().ToLower();//Tutto il testo in minuscolo

    Console.WriteLine("Inserisci la chiave di cifratura");
    int numberKey = Convert.ToInt32(Console.ReadLine());

    char[] secretMessage = userMessage.ToCharArray(); //Copia i caratteri di questa istanza in una matrice di caratteri Unicode
    char[] encryptedMessage = new char[secretMessage.Length];

    for (int i = 0; i < secretMessage.Length; i++)
    {
        char index = secretMessage[i];
        bool letters = Char.IsLetter(index); //controlla che ci siano solo lettere.

        if (letters == true)
        {
            int arrayIndex = Array.IndexOf(alphabet, index);
            int alphabetIndex = (arrayIndex += numberKey) % alphabet.Length;
            char result = alphabet[alphabetIndex];
            encryptedMessage[i] = result;
        }
        else
        {
            encryptedMessage[i] = secretMessage[i];
        }
    }

    string transcription = String.Join("", encryptedMessage);
    Console.WriteLine("Il messaggio criptato è: " + transcription);
}

void Decrypt()
{
    Console.WriteLine("Inserisci il tuo messaggio");
    string userMessage = Console.ReadLine().ToLower(); //Tutto il testo in minuscolo

    Console.WriteLine("Inserisci la chiave di cifratura");
    int numberKey = Convert.ToInt32(Console.ReadLine());

    char[] secretMessage = userMessage.ToCharArray();
    char[] encryptedMessage = new char[secretMessage.Length];

    for (int j = 0; j < secretMessage.Length; j++)
    {
        char index = secretMessage[j];
        bool letters = Char.IsLetter(index);
        if (letters == true)
        {
            int arrayIndex = Array.IndexOf(alphabet, index);
            int alphabetIndex = (arrayIndex -= numberKey) % alphabet.Length;
            char result = alphabet[alphabetIndex];
            encryptedMessage[j] = result;
        }
        else
        {
            encryptedMessage[j] = secretMessage[j];
        }
    }
    string transcription = String.Join("", encryptedMessage);
    Console.WriteLine("Il messaggio decriptato è: " + transcription);
}





////Prova 2 - da rivedere
//char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
//Console.WriteLine("Digita il messaggio");
//string message = Console.ReadLine();
//char[] secretMessage = message.ToCharArray();

//Console.WriteLine("inserisci chiave");
//int key = Convert.ToInt32(Console.ReadLine());
////Scelta azione
//Console.WriteLine("Premi [c] se vuoi CRIPTARE oppure [d] se vuoi DECRIPTARE il messaggio");
//string userChoice = Console.ReadLine();

//char[] encryptedMessage = new char[secretMessage.Length];

//if (userChoice == "c")
//{
//    for (int i = 0; i < secretMessage.Length; i++)
//    {
//        char secretItem = secretMessage[i];
//        int indexEncypt = Array.IndexOf(alphabet, secretItem);
//        int letterPosition = (indexEncypt += key) % 26;
//        char encryptedCharacter = alphabet[letterPosition]; // lo trasformo in char
//        encryptedMessage[i] = encryptedCharacter; // aggiungo al messaggio
//    }
//    string encrypted = String.Join("", encryptedMessage);

//    Console.WriteLine($"Il tuo messaggio cifrato è: \n{encrypted}");
//}
//else if (userChoice == "d")
//{
//    for (int j = 0; j < secretMessage.Length; j++)
//    {
//        char secretItem = secretMessage[j];
//        int indexDecrypt = Array.IndexOf(alphabet, secretItem);
//        int letterPosition = (indexDecrypt -= key) % 26;
//        char encryptedCharacters = alphabet[letterPosition]; //da errore quando inserisco parola in italiano e non la versione criptata
//        encryptedMessage[j] = encryptedCharacters;
//    }
//    string dencrypted = String.Join("", encryptedMessage);

//    Console.WriteLine($"Il tuo messaggio cifrato è: \n{dencrypted}");
//}
//else
//{
//    Console.WriteLine("Errore! Riprova");
//}



//Prova 3 - funziona corretto ma non prende gli spazzi

//Console.WriteLine("Cifrario di Cesare");
////Inizializzo alfabeto
//string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

////Dichiaro variabili
//string textUser, userChoice, result = "";
//int numberKey, index = 0;

////Messaggio user
//Console.WriteLine("Inserisci il tuo messaggio: ");
//textUser = Console.ReadLine().ToUpper();

////Chiave di cifratura
//Console.WriteLine("Inserisci la chiave di cifratura");
//numberKey = Convert.ToInt32(Console.ReadLine());

////Scelta azione
//Console.WriteLine("Premi [c] se vuoi CRIPTARE oppure [d] se vuoi DECRIPTARE il messaggio");
//userChoice = Console.ReadLine();

////Funzione per calcolare modulo - non restituisce indice negativo
//int mod(int n, int b)
//{
//    return (n - b * ((int)Math.Floor((double)n / b))); //Restituisce il valore integrale massimo minore o uguale al numero a virgola mobile a precisione doppia specificato.
//}

//for (int i = 0; i < textUser.Length; i++)
//{
//    if (userChoice == "c") // criptare
//    {
//        index = mod(alphabet.IndexOf(textUser[i]) + numberKey, 26);
//    }
//    else // decriptare
//    {
//        index = mod(alphabet.IndexOf(textUser[i]) - numberKey, 26);
//    }
//    result += alphabet[index];
//}
//Console.WriteLine(result);