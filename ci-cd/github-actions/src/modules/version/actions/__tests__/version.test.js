const versionAction = require('../version');

describe('GET /version', () => {
  describe('when request is successful', () => {
    it('should return 200 on success', () => {
      // GIVEN
      const req = {};
      const res = { status: jest.fn().mockReturnThis(), send: jest.fn() };
      const next = jest.fn();

      // WHEN
      versionAction(req, res, next);

      // THEN
      expect(res.status).toHaveBeenCalledWith(200);
      expect(res.send).toHaveBeenCalledWith({ version: '1.0.0' });
      expect(next).toHaveBeenCalled();
    });
  });
});
