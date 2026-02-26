CREATE OR REPLACE PROCEDURE addTask_SP(
p_userid INTEGER,
p_taskid INTEGER,
p_description VARCHAR(50)
)
LANGUAGE plpgsql
AS
$$
BEGIN
	INSERT INTO taskitem(userid,taskid,description) VALUES(p_userid,p_taskid,p_description);
END
$$