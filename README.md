# PROGETTO CHAT DI GRUPPO: 
### Creazione di un progetto C# di una chat di gruppo, con un server e client multipli. Ho utilizzato il protocollo TCP con una classe TCPListener e TCPClient. Per gestire i client multipli in accesso al server, ho utilizzato una programmazione asincrona con gli oggetti async e await (simili a quelli presenti in Javascript). Inoltre, ho utilizzato dei thread per la gestione. 

# COME UTILIZZARLO: 
### •	Aprire il progetto client andando ad inserire il nome del client che si vuole connettere
### •	Attivare il server utilizzando uno degli IP disponibili e selezionare una porta.
### •	Connettere il client inserendo manualmente l’ip del server e la sua porta


Questo procedimento si può replicare per più clienti simultaneamente. 

Infine, si può inviare del testo che verrà inviato a tutti i client attivati e tramite l’applicazione del server si può andare a scrivere privatamente con un client singolo. Inoltre, il server può disconnettere i client andando a selezionarli dalla listbox presente. 
