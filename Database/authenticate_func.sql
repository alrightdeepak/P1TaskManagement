CREATE OR REPLACE FUNCTION authenticate_func(
p_username VARCHAR(20),
p_password VARCHAR(20)
)
RETURNS TABLE(
userid INTEGER,
username VARCHAR(20),
"password" VARCHAR(20),
usertype VARCHAR(20)
)
LANGUAGE plpgsql
AS
$$
BEGIN
	RETURN QUERY
	SELECT * FROM userdata u WHERE u.username=p_username and u.password=p_password;
END
$$
