//Déclaration des namespaces
using System.Data;
using System.Data.SqlClient;

//Création de la connexion
SqlConnection connection = new SqlConnection();
connexion.ConnectionString = "Data Source=falcort.fr:8083;";
connexion.ConnectionString += "Initial Catalog=restaurant;Persist Security Info=True;User ID=SA;Password=Projet1234";

//Requête SQL (SELECT)
SqlCommand selectCommand = new SqlCommand();
selectCommand.CommandText = "SELECT zz, yy FROM xx WHERE yy = 'uu'"; //zz et yy sont des lignes de la table xx. uu est une donnée à l'intérieur de la table
selectCommand.Connection = connexion;

//Requête SQL (UPDATE)
SqlCommand updateCommand = new SqlCommand();
updateCommand.CommandText = "UPDATE xx SET zz = @zz WHERE yy = @yy"; //On fait un update de la table avec les données
updateCommand.Connection = connexion;

// Paramètres
updateCommand.Parameters.Add("@zz", SqlDbType.NVarChar, 100, "zz");
updateCommand.Parameters.Add("@yy", SqlDbType.NVarChar, 100, "yy");

SqlDataAdapter adapter = new SqlDataAdapter(); // Permet de lire les données
adapter.SelectCommand = selectCommand; // Définitiion la requête SELECT
adapter.UpdateCommand = updateCommand; // Définitiion la requête UPDATE

DataSet data = new DataSet(); // Contiendra les données

try
{
    connexion.Open(); // Ouverture de la connexion
    adapter.Fill(data, "xx"); // Récupère les données de la table
}
catch (Exception ex)
{
    // Affiche des erreurs
    Console.WriteLine(ex.Message);
}
finally
{
    // Fermeture de la connexion à la base de données
    connexion.Close();
}

// Modification du champ "zz"
foreach (DataRow row in data.Tables["xx"].Rows)
{
    row["zz"] = "uu";
}

int lignesModifiees = 0; // Nombre de lignes modifiées
// Modification dans la base de données
lignesModifiees = adapter.Update(data.Tables["xx"]);

Console.WriteLine("{0} ligne(s) modifiée(s)", lignesModifiees);