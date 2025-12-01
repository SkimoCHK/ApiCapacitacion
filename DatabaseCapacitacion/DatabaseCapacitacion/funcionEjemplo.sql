
CREATE OR REPLACE FUNCTION SumarNumeros(n1 int, n2 int)
RETURNS INT AS $$
DECLARE
	resultadoSuma INT;
BEGIN

	IF(N1 < 0 OR n2 < 0) THEN
		RAISE NOTICE 'No se puede mandar numeros negativos';
		return 0;
	END IF;
	
	resultadoSuma := n1 + n2;
	return resultadoSuma;
END;
$$ LANGUAGE plpgsql;

