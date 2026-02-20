CREATE OR REPLACE PROCEDURE changePassword_SP(
p_username VARCHAR(20),
p_password VARCHAR(20)
)
LANGUAGE plpgsql
AS
$$
BEGIN
	UPDATE userdata SET password=p_password WHERE username=p_username;
END;
$$
