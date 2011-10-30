SqlTransaction tn ;  //declare a transaction

const string sql = "INSERT INTO Employees1(EmpID) VALUES (@UserID)";
SqlConnection cn = new SqlConnection("data source=AUG-SQLSRV;initial catalog=HumanResources;integrated security=SSPI");
	 
try
{
	if(cn.State != ConnectionState.Open)
	{
		cn.Open();
	}
}
catch (SqlException ex)
{
	Debug.Assert(false, ex.ToString());
}

tn = cn.BeginTransaction(); //begin transaction

SqlCommand cmd = new SqlCommand(sql, cn,tn);
cmd.Parameters.Clear();
cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = 314;

try
{            
	int i = cmd.ExecuteNonQuery();

	for(int x=0; x<5; x++)
	{
		cmd.Parameters["@UserID"].Value = (315 + x);
		cmd.ExecuteNonQuery();
	}
   
	cmd.Parameters["@UserID"].Value = (325);
	cmd.ExecuteNonQuery();

	tn.Commit(); //commit transaction
}
catch(SqlException ex){
	Debug.Assert(false, ex.ToString());
	tn.Rollback(); //rollback
}
finally
{
	if(cn.State != ConnectionState.Closed){cn.Close();}
	cn.Dispose();
	cmd.Dispose();
	
	tn.Dispose(); //dispose
}