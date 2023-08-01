

namespace Leetcode75;

public static class ContainsDuplicate 
{

	public static Boolean main(int[] nums) {
		Set<Integer> DupeHash = new HashSet<Integer>();
		for (int i=0; i < nums.length; i++) {
			if (DupeHash.contains(nums[i])) {
				return true;
			}
			DupeHash.add(nums[i]);			
		}
		return false;
	}

}