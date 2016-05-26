using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
public class Db : MonoBehaviour {
   public string ArmTable;
   public string score1;
   // Use this for initialization
   void Start () {
      SendData();
   }

   public void SendData()
   {
      string strConn = "Server=localhost;Database=deusProject;Uid=root;Pwd=1111;";
      MySqlConnection conn = new MySqlConnection(strConn);
      InsertUpdate();
      SelectUsingReader();
      conn.Close();
   }
   public void InsertUpdate()
   {
      string strConn = "Server=localhost;Database=deusProject;Uid=root;Pwd=1111;";

      string a = ArmTable;
		//"INSERT INTO armgame(turn_num, score) VALUES ('1',";

		string b = score1;  // 개발팀에서 score 주면 받아옴
		string c = ")";


      using (MySqlConnection conn = new MySqlConnection(strConn))
      {
         conn.Open();
         MySqlCommand cmd = new MySqlCommand(a + b + c, conn);
         cmd.ExecuteNonQuery();


         // cmd.CommandText = "UPDATE Scroe SET Name='Tim' WHERE Id=2";
         // cmd.ExecuteNonQuery();
      }
   }

   public void SelectUsingReader()
   {
      string connStr = "Server=localhost;Database=armGame;Uid=root;Pwd=1111;";

      using (MySqlConnection conn = new MySqlConnection(connStr))
      {
         conn.Open();

         string sql = "SELECT turn_num, count(*) FROM armgame GROUP BY turn_num";
         //ExecuteReader를 이용하여
         //연결 모드로 데이타 가져오기
         MySqlCommand cmd = new MySqlCommand(sql, conn);
         MySqlDataReader rdr = cmd.ExecuteReader();
         while (rdr.Read())
         {
            Console.WriteLine("{0} : {1}", rdr["score"], rdr["turn_num"]);
         }
         rdr.Close();
      }
   }

   // Update is called once per frame
   void Update () {

   }

}
