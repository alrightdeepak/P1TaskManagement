CREATE OR REPLACE FUNCTION getNextTaskId_func(
p_userid INTEGER
)
RETURNS INTEGER
LANGUAGE plpgsql
AS
$$
DECLARE
	nextTaskId INTEGER;
BEGIN
	SELECT COALESCE(MAX(t.taskid)+1,(p_userid*100)+1) INTO nextTaskId FROM taskitem t WHERE t.userid=p_userid;
	RETURN nextTaskId;
END
$$
