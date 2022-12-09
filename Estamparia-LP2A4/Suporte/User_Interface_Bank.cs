using Estamparia_LP2A4.Objetos_Estamp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estamparia_LP2A4.Suporte
{
    internal class User_Interface_Bank
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public User_Interface_Bank()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        // INSERÇÃO NO BANCO DE DADOS
        public void Inserir(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Usuarios VALUES (@Nome, @Email, @Telefone, @CPF, 
                              @Senha, @Perfil)";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
            Cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            Cmd.Parameters.AddWithValue("@Perfil", usuario.Perfil);

            try
            {
                // Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir o usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public Usuario RetornaDadosUser(string Email)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * from Usuarios WHERE Email = @email";
            Cmd.Parameters.AddWithValue("@email", Email);
            SqlDataReader rd = Cmd.ExecuteReader();
            rd.Read();
            Usuario user = new Usuario((int)rd["ID"], (string)rd["Nome"], (string)rd["Email"],
                           (string)rd["Telefone"], (string)rd["CPF"], (string)rd["Senha"], (string)rd["Perfil"]);
            Con.CloseConnection();
            return user;
        }

        // LOGIN DE SISTEMA
        public bool Login(Login login)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * from Usuarios WHERE Email = @email";
            Cmd.Parameters.AddWithValue("@email", login.Email);
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                rd.Read();
                Usuario user = new Usuario((string)rd["Email"], (string)rd["Senha"], (string)rd["Perfil"]);
                if (login.Email == null)
                    MessageBox.Show("Email inválido!");
                else
                {
                    if (BCrypt.Net.BCrypt.Verify(login.Senha, user.Senha))
                    {
                        login.Perfil = user.Perfil;
                        return true;
                    }


                    else
                        MessageBox.Show("Senha inválida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.CloseConnection();
            }
            return false;
        }

        public List<Usuario> listarUsers()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Usuarios";

            List<Usuario> listauser = new List<Usuario>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Usuario user = new Usuario((int)rd["ID"], (string)rd["Nome"], (string)rd["Email"],
                    (string)rd["Telefone"], (string)rd["CPF"], (string)rd["Senha"], (string)rd["Perfil"]);
                    listauser.Add(user);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: Problemas ao realizar a litura de usuários no banco\n" + ex.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listauser;
        }

        public void AlterarComSenha(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @Nome, Email = @Email, Telefone = @Telefone,
                                CPF = @CPF, Senha = @Senha, Perfil = @Perfil
                                WHERE ID = @ID";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
            Cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            Cmd.Parameters.AddWithValue("@ID", usuario.Id);
            Cmd.Parameters.AddWithValue("@Perfil", usuario.Perfil);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void AlterarSemSenha(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @Nome, Email = @Email, Telefone = @Telefone,
                                CPF = @CPF, Perfil = @Perfil
                                WHERE ID = @ID";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
            Cmd.Parameters.AddWithValue("@ID", usuario.Id);
            Cmd.Parameters.AddWithValue("@Perfil", usuario.Perfil);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void DeletarUsuario(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Usuarios WHERE ID = @ID";
            Cmd.Parameters.AddWithValue("@ID", usuario.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao remover usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void InserirProduto(Produtos produto)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Produtos VALUES(@Marca, @Estampa, @Preco, @Cor, @Tamanho,
                              @Quantidade, @Imagem1, @Imagem2)";
            Cmd.Parameters.AddWithValue("@Marca", produto.Marca);
            Cmd.Parameters.AddWithValue("@Estampa", produto.Estampa);
            Cmd.Parameters.AddWithValue("@Preco", produto.Preco);
            Cmd.Parameters.AddWithValue("@Cor", produto.Cor);
            Cmd.Parameters.AddWithValue("@Tamanho", produto.Tam);
            Cmd.Parameters.AddWithValue("@Quantidade", produto.Qtd_estoque);
            Cmd.Parameters.AddWithValue("@Imagem1", produto.Img1);
            Cmd.Parameters.AddWithValue("@Imagem2", produto.Img2);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir o produto no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Produtos> ListarProdutos()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Produtos";

            List<Produtos> listaprod = new List<Produtos>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produtos prod = new Produtos((int)rd["ID_Prod"], (string)rd["Marca"], (string)rd["Estampa"],
                    (int)rd["Quantidade"], (decimal)rd["Preco"], (string)rd["Tamanho"], (string)rd["Cor"],
                    (string)rd["Imagem1"], (string)rd["Imagem2"]);
                    listaprod.Add(prod);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: Problemas ao realizar a litura de usuários no banco\n" + ex.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listaprod;
        }

        public void AlterarProduto(Produtos produto)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Produtos SET Marca = @Marca, Estampa = @Estampa, Preco = @Preco, 
                                Cor = @Cor, Tamanho = @Tamanho, Quantidade = @Quantidade,
                                Imagem1 = @Imagem1, Imagem2 = @Imagem2
                                WHERE ID_Prod =  @ID";

            Cmd.Parameters.AddWithValue("@Marca", produto.Marca);
            Cmd.Parameters.AddWithValue("@Estampa", produto.Estampa);
            Cmd.Parameters.AddWithValue("@Preco", produto.Preco);
            Cmd.Parameters.AddWithValue("@Cor", produto.Cor);
            Cmd.Parameters.AddWithValue("@Tamanho", produto.Tam);
            Cmd.Parameters.AddWithValue("@Quantidade", produto.Qtd_estoque);
            Cmd.Parameters.AddWithValue("@Imagem1", produto.Img1);
            Cmd.Parameters.AddWithValue("@Imagem2", produto.Img2);
            Cmd.Parameters.AddWithValue("@ID", produto.Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void DeletarProduto(int Id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Produtos WHERE ID_Prod = @ID";
            Cmd.Parameters.AddWithValue("@ID", Id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao remover usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public int CriarFatura()
        {
            int FatNum;
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Faturas (Data_Fat) VALUES (@Data)";
            Cmd.Parameters.AddWithValue("@Data", DateTime.Now.ToShortDateString());
            try
            {
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = @"SELECT TOP 1 ID_Fat FROM FATURAS ORDER BY ID_Fat DESC";
                FatNum = Convert.ToInt32(Cmd.ExecuteScalar());
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao criar a fatura.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return FatNum;
        }

        public void InserirProdCarrinho(int FatNum, Item_Carrinho Item)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Carrinho VALUES (@IdFat, @IdProd, @QtdProd)";
            Cmd.Parameters.AddWithValue("@IdFat", FatNum);
            Cmd.Parameters.AddWithValue("@IdProd", Item.IdProd);
            Cmd.Parameters.AddWithValue("@QtdProd", Item.qtdItem);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir produto no carrinho de compras.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Produtos> ListaCarrinho(int FatNum)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT	Produtos.ID_Prod, Produtos.Marca, Produtos.Estampa, Produtos.Cor,
                                        Produtos.Tamanho, Produtos.Preco, Carrinho.QtdProd_Carr,
		                                Produtos.Imagem1, Produtos.Imagem2
                                FROM    Produtos INNER JOIN Carrinho ON Produtos.ID_Prod = Carrinho.FK_ID_Prod
                                        INNER JOIN Faturas ON Carrinho.FK_ID_Fat = Faturas.ID_Fat
                                WHERE   FK_ID_Fat = @NumFat";
            Cmd.Parameters.AddWithValue("@NumFat", FatNum);
            List<Produtos> ListaCarr = new List<Produtos>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produtos prod = new Produtos((int)rd["ID_Prod"], (string)rd["Marca"], (string)rd["Estampa"],
                    (int)rd["QtdProd_Carr"], (decimal)rd["Preco"], (string)rd["Tamanho"], (string)rd["Cor"],
                    (string)rd["Imagem1"], (string)rd["Imagem2"]);
                    ListaCarr.Add(prod);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: Problemas ao realizar a leitura do carrinho no banco\n" + ex.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return ListaCarr;
        }

        public void DeletarItemCarr(int IdProd, int FatNum)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Carrinho WHERE FK_ID_Fat = @FatNUm AND FK_ID_Prod = @IdProd";
            Cmd.Parameters.AddWithValue("@FatNum", FatNum);
            Cmd.Parameters.AddWithValue("@IdProd", IdProd);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao remover o item do carrinho.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void RealizarCompra(int FatNum, int IdCli, decimal TotalFat)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Faturas SET FK_ID_User = @IdCli, Total_Fat = @TotalFat, 
                                Status_Fat = 'Finalizada' WHERE ID_Fat = @FatNum";
            Cmd.Parameters.AddWithValue("@FatNum", FatNum);
            Cmd.Parameters.AddWithValue("@IdCli", IdCli);
            Cmd.Parameters.AddWithValue("@TotalFat", TotalFat);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a compra.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Fatura> RelatorioVendasTotal()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT	Usuarios.Nome,
		                                Usuarios.Email,
		                                Faturas.Data_Fat,
		                                Faturas.Total_Fat
                                FROM Usuarios INNER JOIN Faturas ON Faturas.FK_ID_User = Usuarios.ID
                                WHERE Faturas.Status_Fat = 'Finalizada'";

            List<Fatura> ListaFat = new List<Fatura>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Fatura Fat = new Fatura((string)rd["Nome"], (string)rd["Email"], Convert.ToDateTime(rd["Data_Fat"]).ToShortDateString(),
                    (decimal)rd["Total_Fat"]);
                    ListaFat.Add(Fat);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: Problemas ao realizar a litura das faturas no banco\n" + ex.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return ListaFat;
        }

        public List<Fatura> RelatorioVendasData(string Data)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT	Usuarios.Nome,
		                                Usuarios.Email,
		                                Faturas.Data_Fat,
		                                Faturas.Total_Fat
                                FROM Usuarios INNER JOIN Faturas ON Faturas.FK_ID_User = Usuarios.ID
                                WHERE Faturas.Status_Fat = 'Finalizada' AND Faturas.Data_Fat LIKE @Data";
            Cmd.Parameters.AddWithValue("@Data", Data);
            List<Fatura> ListaFat = new List<Fatura>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Fatura Fat = new Fatura((string)rd["Nome"], (string)rd["Email"], Convert.ToDateTime(rd["Data_Fat"]).ToShortDateString(),
                    (decimal)rd["Total_Fat"]);
                    ListaFat.Add(Fat);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO: Problemas ao realizar a litura das faturas no banco\n" + ex.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return ListaFat;
        }

    }
}
