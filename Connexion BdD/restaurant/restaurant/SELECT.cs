//Déclaration des namespaces
using System.Data;
using System.Data.SqlClient;

//Création de la connexion
SqlConnection connection = new SqlConnection();
connexion.ConnectionString = "Data Source=falcort.fr:8083;";
connexion.ConnectionString += "Initial Catalog=restaurant;Persist Security Info=True;User ID=SA;Password=Projet1234";

//Requête SQL
SqlCommand selectCommand = new SqlCommand();
selectCommand.Connection = connexion; //la connexion a été instanciée auparavant
selectCommand.CommandText = "SELECT * FROM xxx"; //insérer le nom de la table

SqlDataAdapter adapter = new SqlDataAdapter(selectCommand); //Permet de lire les données
DataSet data = new DataSet(); //Contiendra les données que l'on va récupérer.

try
{
    connexion.Open(); //Ouverture de la connexion
    adapter.Fill(data, "xxx"); //Récupère les données 
}
catch (Exception ex)
{
    //Affiche les erreurs
    Console.WriteLine(ex.Message);
}
finally
{
    //Fermeture de la connexion à la base de données (on est en mode déconnecté)
    connexion.Close();
}

//Affiche dans la console
foreach (DataRow row in data.Tables["xxx"].Rows) //Remplacer xxx par la table
{
    Console.WriteLine(row["zzz"]); //zzz est une ligne de xxx