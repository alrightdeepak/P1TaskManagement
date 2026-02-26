CREATE OR REPLACE FUNCTION GetAll_func(
p_roletype VARCHAR
)
RETURNS TABLE(
userid INTEGER,
username VARCHAR(20),
usertype VARCHAR(20)
)
LANGUAGE plpgsql
AS
$$
BEGIN
	RETURN QUERY
	SELECT u.userid as userid, u.username as username, u.usertype as usertype
	FROM userdata u 
	WHERE u.usertype=p_roletype
	ORDER BY userid ASC;
END
$$