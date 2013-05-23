class Proposition

  attr_accessor :value

  def and(other)
    @value && other.value
  end

  def or(other)
    @value || other.value
  end

  def hook(other)
    if self.and(other)
      true
    elsif !@value and other.value
      true
    elsif !@value and !other.value
      true
    end
    false
  end

  def ==(other)
    @value == other.value
  end

  def !=(other)
    @value != other.value
  end

end