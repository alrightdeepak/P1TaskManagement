CREATE OR REPLACE FUNCTION validate_func(
p_username VARCHAR(20)
)
RETURNS BOOLEAN
LANGUAGE plpgsql
AS
$$
DECLARE
	user_count INTEGER;
BEGIN
	SELECT COUNT(*) INTO user_count FROM userdata u WHERE u.username=p_username;
	RETURN user_count>0;
END
$$