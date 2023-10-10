#if !defined(EMPRESTIMO_HPP)
#define EMPRESTIMO_HPP

#include"Livro.hpp"
#include"User.hpp"
#include"Data.hpp"

class Emprestimo{
    private:
        static int cont;
        string id;
        Livro* livro;
        Usuario* usuario;
        string status;
        Data* dt_retirada;
        Data* dt_devolucao;
    public:
        Emprestimo(Livro*, Usuario*, string, Data*, int);
        
        void setLivro(Livro*);
        void setUsuario(Usuario*);
        void setStatus(string);
        void setDt_retirada(Data*);
        void setDt_devolucao(Data*);

        string getId();
        Livro* getLivro();
        Usuario* getUsuario();
        string getStatus();
        Data* getDt_retirada();
        Data* getDt_devolucao();

        string toString();

        ~Emprestimo(){}
};

#endif // EMPRESTIMO_HPP
