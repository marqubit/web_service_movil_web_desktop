<?php
class Consultas{
    private $conexion;
    private $results;
    private $mysqli;
    
    public function __construct() {
        $this->conexion = new Conexion();
        $this->mysqli = $this->conexion->mysqli;
    }
    
    public function consultar(){
        $query = "SELECT * FROM canciones "." JOIN generos";
                //. "LEFT JOIN genero ON genero.idgenero = canciones.idgenero ";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
    
    public function listarArtistas(){
        $query = "SELECT artista FROM canciones "
                . "GROUP BY artista ORDER BY artista ASC ";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
	
	public function VerGeneros(){
        $query = "SELECT * FROM generos "
		. "GROUP BY genero ORDER BY genero ASC";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
	
	public function Porgenero($genero){
        $query = "SELECT genero, count(*) as canciones FROM canciones inner JOIN generos ON canciones.idgenero = generos.idgenero where genero LIKE '%".$genero."%' GROUP BY genero";
		print $query;
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
	//public function Regresa($genero){
      //  $query = "SELECT genero, count(*) as canciones FROM canciones inner JOIN generos ON canciones.idgenero = generos.idgenero WHERE genero='".$genero."' GROUP BY genero";
        //$res = $this->mysqli->query($query);
        //$this->results = $res->fetch_all(MYSQLI_ASSOC);
        //return $this->results;
//}
	public function generojunto(){	//$genero){
        $query = "SELECT canciones.nombre,canciones.artista,generos.genero FROM canciones INNER JOIN generos ON canciones.idGenero = generos.idGenero ORDER BY genero";
        $res = $this->mysqli->query($query);
        $this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;
    }
 public function Insertar($nombre, $artista,$idgenero){
        $query = "INSERT into canciones('nombre','artista','idgenero') values ('".$nombre."','".$artista."','".$idgenero."') ";
        $res = $this -> mysqli -> query($query);
		$this->results = $res->fetch_all(MYSQLI_ASSOC);
        return $this->results;

    }
}
	//, $idGenero....,idGenero
//,'".$idGenero."'
//$miConsulta = new Consultas();
//$miConsulta->consultar();