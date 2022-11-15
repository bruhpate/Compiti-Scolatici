// See https://aka.ms/new-console-template for more information

class ContoCorrente{
    private string _id;
    private string _cliente;
    private string _banca;
    private float _saldo;

    public ContoCorrente(string id1, string cliente1, string banca1){
        _id = id1;
        _cliente = cliente1;
        _banca = banca1;
        _saldo = 0;
    }
    
    //stessa roba per il resto
    string id{
        get{
            return _id;
        }
        set{
            _id=value;
        }
    }
    string banca{
        get{
            return _banca;
        }
        set{
            _banca=value;
        }
    }
    public float saldo{
        get{
            return _saldo;
        }
        set{
            _saldo=value;
        }

    string cliente{
        get{
            return _cliente;
        }
        set{
            _cliente=value;
        }

    public void deposita(float importo){

                saldo+=importo;
    }
    public void preleva(float importo){
                saldo-=importo;
    }

    public void bonifico(ContoCorrente cc, float importo){
                saldo -= importo;
                cc.saldo += importo;
    }
}

class CartaBancomat{
    private string _id;
    private string _pin;
    private ContoCorrente _conto;

    public CartaBancomat(string id1, string pin1){
        _id = id1;
        _pin=pin1;
    }
        string id{
        get{
            return _id;
        }
        set{
            _id=value;
        }
        string pin{
            get{
                return _pin;
            }
            set{
                _pin = value;
            }
        }
        CartaBancomat conto{
           get{
            return _conto;
           } 
           set{
            
           }
        }
        
        public void deposita(){
            
        }
}