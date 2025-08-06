function convert(f)
  local result = (f - 32) * (5 / 9)
  return result
end

print(convert(94))

input = io.read("Enter a number: ")

local l = (input - 32) * (5 / 9)
print(l)
