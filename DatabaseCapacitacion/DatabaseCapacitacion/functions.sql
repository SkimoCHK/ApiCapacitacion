
CREATE OR REPLACE FUNCTION fun_get_categories()
RETURNS setof categorias AS $$
DECLARE

BEGIN
	RETURN QUERY SELECT * FROM categorias;
END;
$$LANGUAGE plpgsql;


SELECT * FROM fun_get_categories()


CREATE OR REPLACE FUNCTION fun_create_categorie(
p_nombre varchar,
p_estatus bool
)
RETURNS SETOF categorias AS $$
BEGIN
	RETURN QUERY
	INSERT INTO categorias(nombre, estatus)
	VALUES (p_nombre, p_estatus)
	RETURNING *;
END;
$$ LANGUAGE plpgsql;


SELECT * FROM fun_create_categorie('Alimentos',true)
