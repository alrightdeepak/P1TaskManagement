CREATE OR REPLACE PROCEDURE deleteTask_SP(
p_taskid INTEGER,
p_userid INTEGER
)
LANGUAGE plpgsql
AS
$$
BEGIN
	DELETE FROM taskitem WHERE taskid=p_taskid and userid=p_userid;
END
$$