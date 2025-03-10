using Biblio2.DAL;
using Biblio2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio2.BLL
{
    public class LivroRequisicaoBLL
    {
        //Objetos globais
        LivroRequisicaoDTO livroRequisicaoDTO = new LivroRequisicaoDTO();
        LivroRequisicaoDAL livroRequisicaoDAL = new LivroRequisicaoDAL();

        //CRUD parcial - CREATE, READ & DELETE

        // CREATE
        public void CreateLivroRequisicaoBLL(LivroRequisicaoDTO livro)
        {
            livroRequisicaoDAL.CreateLivroRequisicao(livro);
        }

        //READ
        public List<LivroRequisicaoDTO> GetLivroRequisicaoBLL()
        {
            return livroRequisicaoDAL.GetLivroRequisicao();
        }

        //DELETE
        public void DeleteLivroRequisicaoBLL(int idLivroRequisicao)
        {
            livroRequisicaoDAL.DeleteLivroRequisicao(idLivroRequisicao);
        }

        //FUNÇÕES ESPECIAIS

        //GetGenero
        public List<GeneroDTO> GetGeneroLivroRequisicaoBLL()
        {
            return livroRequisicaoDAL.GetGeneroLivroRequisicao();
        }

        //SearchById
        public LivroRequisicaoDTO SearchByIdLivroRequisicaoBLL(int idLivroRequisicao)
        {
            return livroRequisicaoDAL.SearchByIdLivroRequisicao(idLivroRequisicao);
        }

        //ApproveLivroRequisicao
        public void ApproveLivroRequisicaoBLL(int idLivroRequisicao)
        {
            livroRequisicaoDAL.ApproveLivroRequisicao(idLivroRequisicao);
        }
    }
}
    

